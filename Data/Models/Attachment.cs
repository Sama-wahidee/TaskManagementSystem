﻿using System.ComponentModel.DataAnnotations;
//19/8 v2

namespace TaskManagementSystem.Data.Models
{
    public class Attachment
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public long Size { get; set; }
        public string PhysicalPath { get; set; }
        public string Type { get; set; }
        public bool IsDeleted { get; set; }
        //Commit test
        
        public User User { get; set; }
        
        public Task Task { get; set; }
        public Project Project { get; set; }


    }
}

