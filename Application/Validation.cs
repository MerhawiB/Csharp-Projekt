using Application.Exceptions;
using DataAccess.Repository;
using System;
using System.Linq;
using System.Text.RegularExpressions;

//Validation class that uses extension methods for checking conditions in the GUI

namespace Application
{
    public static class Validation
    {
        private static readonly PodCastRepository _podcastRepository = new PodCastRepository();
        private static readonly CategoryRepository _categoryRepository = new CategoryRepository();
        public static string CheckIfSameCategory(this string str, string oldname = null)
        {
            if (_categoryRepository.GetAll().ToList().Count > 0)
            {
                if (_categoryRepository.GetCategory(str) != null && oldname != str)
                {
                    {
                        throw new SameValueException();
                    }
                }
            }
            return str;
        }
        public static string CheckIfSame(this string str, string oldname = null)
        {
            if (_podcastRepository.GetAll().ToList().Count > 0)
            {
                if (_podcastRepository.GetPodcast(str) != null && oldname != str)
                {
                    {
                        throw new SameValueException();
                    }                 
                }
            }
            return str;
        }
        public static string CheckIfSameUrl(this string str, string oldname = null)
        {
            if (_podcastRepository.GetAll().ToList().Count > 0)
            {
                if (_podcastRepository.GetPodcastByUrl(str) != null && oldname != str)
                {
                    {
                        throw new SameUrlValueException();
                    }
                }
            }
            return str;
        }
        public static string CheckIfEmpty(this string str)
        {
            if (String.IsNullOrWhiteSpace(str))
            {
                throw new EmptyValueException();
            }
            return str;
        }
        public static string CheckIfCancel(this string str)
        {
            if (String.IsNullOrWhiteSpace(str))
            {
                throw new CancelOrEmtpyException();
            }
            return str;
        }
        public static T CheckIfObjectIsEmpty<T>(this T usedobject) where T: class
        {
            if (usedobject == null)
            {
                throw new NoValueAtIndexException();
            }
            return usedobject;
        }
        public static T CheckIfURLIsValid<T>(this T usedobject) where T : class
        {
            if (usedobject == null)
            {
                throw new NotAValidURLException();
            }
            return usedobject;
        }
        // Validation which uses Regex for checking if it is a URL
        public static string CheckIfURL(this string urlcheck)
        {
            var regex = new Regex("^(http|https)://");
            if (!regex.IsMatch(urlcheck))
            {
                throw new NotAValidURLException();
            }
            return urlcheck;
        }
        public static int CheckIfIndexExist(this int index)
        {
            if (index < 1)
            {
                throw new NoIndexException();
            }
            return index;
        }
    }
}
