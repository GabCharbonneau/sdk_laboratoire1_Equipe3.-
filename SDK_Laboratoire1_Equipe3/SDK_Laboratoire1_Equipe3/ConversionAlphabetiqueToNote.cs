namespace SDK_Laboratoire1_Equipe3
{
    public class ConversionAlphabetiqueToNote
    {
        
        public string TransformationNote(string entree)
        {
            switch (entree)
            {
                case "A":
                    return "Note: LA";
                    break;
                case "B":
                    return "Note: SI";
                    break;
                case "C":
                    return "Note: DO";
                    break;
                case "D":
                    return "Note: RE";
                    break;
                case "E":
                    return "Note: MI";
                    break;
                case "F":
                    return "Note: FA";
                    break;
                case "G":
                    return "Note: SOL";
                    break;
                default:
                    return "Reessayer";
                    break;
            }
        }
    }
}
