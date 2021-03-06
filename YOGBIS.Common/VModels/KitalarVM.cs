using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace YOGBIS.Common.VModels
{
    public class KitalarVM
    {
        [Key]
        public int KitaId { get; set; }
        public string KitaAdi { get; set; }
        public string KitaAciklama { get; set; }
        public int UlkeGrupId { get; set; }
        public UlkeGruplariVM UlkeGruplariVm { get; set; }
    }
}
