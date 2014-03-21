using System.Globalization;

namespace DataScanner.ResourceLoader {
    public class FreelancerIdConverter : IFreelancerIdConverter {
        public int Convert(int id) {
            var value = 0;

            if(id > 0) {
                var hexValue = id.ToString("X").Substring(1);

                value = int.Parse(hexValue, NumberStyles.HexNumber);
            }

            return value;
        }
    }
}
