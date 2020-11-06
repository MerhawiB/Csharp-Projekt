using Application;
using Application.Exceptions;
using Microsoft.VisualBasic;
using Model;
using Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

// The Users GUI 

namespace RSSReader
{
    public partial class frmRss : Form
    {
        private readonly PodCastController _podcastController;
        private readonly EpisodeController _episodeController;
        private readonly CategoryController _categoryController;
        private readonly Timer _timer;
        public frmRss(){         
            InitializeComponent();
            _categoryController = new CategoryController();        
            _podcastController = new PodCastController();
            _episodeController = new EpisodeController();
            _timer = new Timer();
            FillIntervallComboBox();
            FillCategoryComboBox();
            ShowCategory();
            ShowPodCastSubscriptions();
            _timer.Interval = 5000;         
            _timer.Tick += Timer_Tick;        
            _timer.Start();          
        }
        private void FillIntervallComboBox()
        {
            cmbBoxInterval.Items.Add("1");         
            cmbBoxInterval.Items.Add("5");          
            cmbBoxInterval.Items.Add("10");
        }
        //The methods are orderd from top to bottom first are all the events and methods regarding to Podcasts and then Categories
        private async void btnNewPodcast_Click_1Async(object sender, EventArgs e)
        {
            try
            {
                var podname = Interaction.InputBox("Namnge podcasten: ", "Spara", "NyPodcast").CheckIfCancel();
                var podCastDTO = new PodCastDTO { Url = txtUrl.Text.CheckIfURL().CheckIfSameUrl(), 
                Interval = double.Parse(cmbBoxInterval.Text.CheckIfEmpty()), 
                CategoryId = _categoryController.GetCategory(cmbBoxCategory.Text.CheckIfEmpty()),
                Name = podname.CheckIfEmpty().CheckIfSame() };
                await _podcastController.CreatePodcastAsync(podCastDTO);
                ShowPodCastSubscriptions();          
            }

            catch (EmptyValueException err)
            {
                MessageBox.Show(err.ErrorMessage());
            }
            catch (NotAValidURLException err)
            {
                MessageBox.Show(err.ErrorMessage());
            }
            catch (CancelOrEmtpyException)
            {}
            catch (SameValueException err)
            {
                MessageBox.Show(err.ErrorMessage());
            }
            catch (SameUrlValueException err)
            {
                MessageBox.Show(err.ErrorMessage());
            }
        }
        private void btnRemovePodCast_Click(object sender, EventArgs e)
        {
            try
            {
                lstVPodcast.SelectedItems.Count.CheckIfIndexExist();
                var selectedPod = lstVPodcast.SelectedItems[0].SubItems[1].Text;
                var podId = _podcastController.GetPodCast(selectedPod).Id;
                _podcastController.DeletePodCast(podId);
                _episodeController.DeleteEpisodes(podId);
                ShowPodCastSubscriptions();
                lstBoxEpisodes.Items.Clear();       
                txtBoxEpisodeDescription.Clear();
            }
            catch (NoValueAtIndexException err){
                MessageBox.Show(err.ErrorMessage());
            }
            catch (NoIndexException)
            {
            }
        }
        private void ShowPodCastSubscriptions(){
            lstVPodcast.Items.Clear();
            var subcribedPods = _podcastController.GetAllPodCasts().ToList();       
            foreach (var pod in subcribedPods)
            {
                ListViewItem lvItem = new ListViewItem(pod.AmountOfEpisodes.ToString(), 0);            
                lvItem.SubItems.Add(pod.Name.ToString());            
                lvItem.SubItems.Add(pod.UpdateInterval.ToString());               
                lvItem.SubItems.Add(_categoryController.GetCategory(pod.CategoryId));               
                lstVPodcast.Items.Add(lvItem);                          
            }
        }
        private void ShowPodCastSubscriptions(Guid id)
        {
            lstVPodcast.Items.Clear();
            var subcribedPods = _podcastController.GetPodCastByCategory(id);
            foreach (var pod in subcribedPods)
            {
                ListViewItem lvItem = new ListViewItem(pod.AmountOfEpisodes.ToString(), 0);
                lvItem.SubItems.Add(pod.Name.ToString());
                lvItem.SubItems.Add(pod.UpdateInterval.ToString());
                lvItem.SubItems.Add(_categoryController.GetCategory(pod.CategoryId));
                lstVPodcast.Items.Add(lvItem);
            }
        }
        private void lstVPodcast_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selecteddPod = lstVPodcast.FocusedItem.SubItems[1].Text;
            lstBoxEpisodes.Items.Clear();
            txtBoxEpisodeDescription.Clear();
            var podCastName = _podcastController.GetPodCast(selecteddPod).Name;
            var podCastUrl = _podcastController.GetPodCast(selecteddPod).Url;
            lblPodcast.Text = podCastName;
            txtUrl.Text = podCastUrl;         
            GetEpisodes();
        }
        private async void btnUpdatePodCast_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                lstVPodcast.SelectedItems.Count.CheckIfIndexExist();
                string podname = Interaction.InputBox("Namnge podcasten: ", "Spara", lstVPodcast.SelectedItems[0].SubItems[1].Text.CheckIfObjectIsEmpty().ToString()).CheckIfCancel();
                var podCastDTO = new PodCastDTO
                {
                    Url = txtUrl.Text.CheckIfURL(),
                    Interval = double.Parse(cmbBoxInterval.Text.CheckIfEmpty()),
                    CategoryId = _categoryController.GetCategory(cmbBoxCategory.Text.CheckIfEmpty()),
                    Name = podname.CheckIfEmpty().CheckIfSame(podname)
                };
                var selectedPod = lstVPodcast.FocusedItem.SubItems[1].Text;
                var podId = _podcastController.GetPodCast(selectedPod).Id;
                await _podcastController.UpdatePodcastAsync(podId, podCastDTO);
                FillCategoryComboBox();
                ShowPodCastSubscriptions();
            }
            catch (EmptyValueException err)
            {
                MessageBox.Show(err.ErrorMessage());
            }
            catch (NotAValidURLException err)
            {
                MessageBox.Show(err.ErrorMessage());
            }
            catch (CancelOrEmtpyException){}
            catch (SameValueException){}
            catch (NoIndexException){}
        }
        private void GetEpisodes() 
        {
            PodCast pod = _podcastController.GetPodCast(lblPodcast.Text);
            var podId = pod.Id;
            var episodes = _episodeController.GetAllEpisodes(podId).ToList();         
            episodes.Reverse();         
            foreach (var episode in episodes)
            {
                lstBoxEpisodes.Items.Add(episode.Title);
            }
            lblPodCastDescription.Text = "Avsnittsbeskrivning";
        }
        private void lstBoxEpisodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var podcast = _podcastController.GetPodCast(lblPodcast.Text);
            var podcastId = podcast.Id;
            var episodes = _episodeController.GetAllEpisodes(podcastId).ToList();
            var index = (podcast.AmountOfEpisodes) - lstBoxEpisodes.SelectedIndex;
            txtBoxEpisodeDescription.Text = episodes[index-1].Description.Replace("<br/><br/>", "");
            lblPodCastDescription.Text = "Avsnitt: " + (lstBoxEpisodes.SelectedIndex + 1);
        }     
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new Category { Name = txtBoxCategory.Text.CheckIfEmpty().CheckIfSameCategory() };
                lstBoxCategory.Items.Add(category.Name);
                _categoryController.CreateCategory(category);
                FillCategoryComboBox();
            }
            catch (EmptyValueException  err)
            {
                MessageBox.Show(err.ErrorMessage());
            }
            catch (SameValueException err)
            {
                MessageBox.Show(err.ErrorMessage());
            }
        }    
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                lstBoxCategory.SelectedItem.CheckIfObjectIsEmpty();
                var confirmResult = MessageBox.Show("Är du säker på att du vill ta bort kategorin och all dess data?", "TA BORT KATEGORI",
                MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var category = lstBoxCategory.SelectedItem.CheckIfObjectIsEmpty().ToString();
                    var categoryId = _categoryController.GetCategory(category);
                    _categoryController.DeleteCategory(categoryId);
                    FillCategoryComboBox();
                    ShowPodCastSubscriptions();
                    ShowCategory();
                    lstBoxEpisodes.Items.Clear();
                    txtBoxEpisodeDescription.Clear();                   
                    cmbBoxCategory.Text = "";
                    txtBoxCategory.Text = ""; 
                }             
            }
            catch (NoValueAtIndexException)
            {
            }
        }
        private void btnChangeCategoryName_Click(object sender, EventArgs e)
        {
            try
            {
                var oldCategoryName = lstBoxCategory.SelectedItem.CheckIfObjectIsEmpty().ToString();
                var categoryName = Interaction.InputBox("Namnge kategorin: ", "Spara", 
                lstBoxCategory.SelectedItem.CheckIfObjectIsEmpty().ToString()).CheckIfCancel().CheckIfSameCategory(oldCategoryName);
                var category = lstBoxCategory.SelectedItem.CheckIfObjectIsEmpty().ToString();
                var categoryId = _categoryController.GetCategory(category);
                _categoryController.UpdateCategory(categoryId, categoryName);
                ShowCategory();
                FillCategoryComboBox();
                ShowPodCastSubscriptions();
                cmbBoxCategory.Text = "";
                txtBoxCategory.Text = "";
            }
            catch (NoValueAtIndexException)
            {
                
            }
            catch (CancelOrEmtpyException){}
            catch (SameValueException err)
            {
                MessageBox.Show(err.ErrorMessage());
            }
        }   
        private void ShowCategory()
        {
            lstBoxCategory.Items.Clear();
            List<Category> categories;
            categories = _categoryController.GetAllCategory().ToList();
            foreach (var category in categories)
            {
                lstBoxCategory.Items.Add(category.Name);
            }
        }
        private void FillCategoryComboBox()
        {
            cmbBoxCategory.Items.Clear();
            List<Category> categories;
            categories = _categoryController.GetAllCategory().ToList();
            foreach (var category in categories)
            {
                cmbBoxCategory.Items.Add(category.Name);
            }
        }
        private async void Timer_Tick(object sender, EventArgs e)
        {
            await _podcastController.CheckUpdateAsync();
        }
        private void btnFilterEpisodes_Click(object sender, EventArgs e)
        {
            try
            {
                lstVPodcast.SelectedItems.Clear();
                var category = lstBoxCategory.SelectedItem.CheckIfObjectIsEmpty().ToString();
                txtBoxCategory.Text = category;
                var categoryId = _categoryController.GetCategory(category);
                ShowPodCastSubscriptions(categoryId);
            }
            catch (NoValueAtIndexException) { }
        }
        private void btnShowAllPodCast_Click(object sender, EventArgs e)
        {
            ShowPodCastSubscriptions();
        }
    }
}
