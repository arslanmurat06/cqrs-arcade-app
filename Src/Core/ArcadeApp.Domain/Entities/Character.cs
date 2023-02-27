using System;
using System.Formats.Asn1;
using ArcadeApp.Domain.Common;

namespace ArcadeApp.Domain.Entities
{
    public class Character : BaseEntity
    {
        public string Name { get; set; } = "Frodo";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
    }
}
