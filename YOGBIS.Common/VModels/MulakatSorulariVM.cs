﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using YOGBIS.Data.DbModels;

namespace YOGBIS.Common.VModels
{
    public class MulakatSorulariVM
    {
        [Key]
        public int MulakatSorulariId { get; set; }
        public int SoruSiraNo { get; set; }
        public int SoruNo { get; set; }
        public int KategoriId { get; set; }
        public string Derecesi { get; set; }
        public string Soru { get; set; }
        public string Cevap { get; set; }
        public int MulakatId { get; set; }
        public Mulakatlar Mulakatlar { get; set; }
    }
}
