namespace MyFirstWebAPI.Models.CustomException
{
    internal class ValidateRawImageData
    {
        public void Validate(string rawdata)
        {
            if ( (rawdata.Length <= 1) || rawdata.Equals(null))
            {
                throw new EmptyStringException (" causes: \n\t 1. Image is Empty or contains no text \n\t 2. Ran into some problem: Server down! ");

            }
           
        }
    }
}