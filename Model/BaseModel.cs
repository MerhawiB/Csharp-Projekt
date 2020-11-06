using System;


//Abstract class so that the other model classes all can inherit Guid Id, this was used mainly for better use of the BaseRepository class. 

namespace Model
{
    public abstract class BaseModel
    {
          public Guid Id { get; set; }

    }
}
