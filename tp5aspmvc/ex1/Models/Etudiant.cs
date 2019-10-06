﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ex1.Models
{
    public class Etudiant
    {
        [Key]
        public String Cne
        {
            get; set;
        }

        public String Nom
        {
            get; set;
        }

        public String Prenom
        {
            get; set;
        }

        public int Age
        {
            get; set;
        }
    }
}