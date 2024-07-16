namespace HomeWork
{
    public class Canli
    {
        public string Deri { get; set; }
        public bool NefesAlir { get; set; } = true;
        public bool AyagiVar { get; set; }
        public string Artir { get; set; }

        public string GetDescription()
        {
            string description = $"Canlinin Dərisi: {Deri} -dur";
            description += $", Nəfəs alır ";
            if (!string.IsNullOrEmpty(Artir))
            {
                description += $", {Artir} artır";
            }
            description += AyagiVar ? " yeriyərək hərəkət edir" : " Sürünərək hərəkət edir";
            return description;
        }

    }
    public class Insan : Canli
    {
        public string Name { get; set; }
        public string Dil { get; set; }
        public string Ixtisas { get; set; }


        public new string GetDescription()
        {
            string description = $"Canlinin Dərisi: {Deri} ";
            description += $", Nəfəs alır ";
            if (!string.IsNullOrEmpty(Artir))
            {
                description += $", {Artir}  artır";
            }
            description += AyagiVar ? " yeriyərək hərəkət edir" : " Sürünərək hərəkət edir";

            description += $", Adi {Name} dir  ";
            description += $", {Dil} Dilində danışır";
            description += $", Peşəsi: {Ixtisas}-dir";
            if ((Ixtisas) == "IT")
            {
                description += $", və Kolleqadır";
            }
            return description;
        }
        public new string GetDescription(string Ders)
        {
            return $"{Ders} yazmag lazimdir";
        }
    }
}
