﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Skill_CodeFirst_Project.Models.siniflar
{
    public class Yetenekler
    {
        [Key]
        public int Id { get; set; }
        public string Aciklama { get; set; }
        public byte Deger { get; set; }
    }
}