﻿namespace DataScanner.ResourceLoader {
    public class FreelancerStringLoader {
        private readonly IStringLoader loader;
        private readonly IFreelancerIdConverter converter;

        public FreelancerStringLoader(IStringLoader stringLoader, IFreelancerIdConverter converter) {
            this.loader = stringLoader;
            this.converter = converter;
        }

        public string GetString(int id) {
            var value = string.Empty;
            var convertedId = this.converter.Convert(id);

            if(convertedId > 0) {
                value = loader.Load(convertedId);
            }

            return value;
        }

        public void Dispose() {
            if(this.loader != null) {
                this.loader.Dispose();
            }
        }
    }
}