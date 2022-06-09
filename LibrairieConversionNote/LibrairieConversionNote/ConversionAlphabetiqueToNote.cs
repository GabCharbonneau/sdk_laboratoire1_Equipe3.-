namespace LibrairieConversionNote
{
    public class ConversionAlphabetiqueToNote
    {
        public string
        public string Transformer (string entree)
        {
            switch (entree)
            {
                case "A":
                    return "LA";
                    break;
                case "B":
                    return "SI";
                    break;
                case "C":
                    return "DO";
                    break;
                case "D":
                    return "RE";
                    break;
                case "E":
                    return "MI";
                    break;
                case "F":
                    return "FA";
                    break;
                case "G":
                    return "SOL";
                    break;
                default: "Reessayer";
                    break;
            }
        }
    }
}