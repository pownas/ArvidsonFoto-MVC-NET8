﻿using System;
using System.Collections.Generic;

namespace ArvidsonFoto.Models
{
    public class UploadEditImagesViewModel
    {
        public List<UploadImageInputModel> DisplayImagesList { get; set; }

        public List<TblImage> AllImagesList { get; set; }

        //public UploadImageInputModel ImageInputModel { get; set; } //För att editera??

        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
        public string CurrentUrl { get; set; }
        public string DisplayMessage { get; set; }
        public string UpdatedId { get; set; }
    }
}