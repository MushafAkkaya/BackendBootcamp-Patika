﻿namespace PatikaBlog.Models
{
    public class Category
    {
        public Category()
        {
            CreatedDate = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }

    }
}
