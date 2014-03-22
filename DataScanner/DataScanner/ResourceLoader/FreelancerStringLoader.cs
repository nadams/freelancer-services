using System;
using DataScanner.Common;

namespace DataScanner.ResourceLoader {
    public class FreelancerStringLoader : IDisposable {
        private readonly IStringLoader loader;
        private readonly IFreelancerIdConverter converter;

        public FreelancerStringLoader(IStringLoader stringLoader, IFreelancerIdConverter converter) {
            Assert.IsNotNull(stringLoader, "stringLoader");
            Assert.IsNotNull(converter, "converter");

            this.loader = stringLoader;
            this.converter = converter;
        }

        public IOption<string> GetString(int id) {
            IOption<string> value = new None<string>();
            var convertedId = this.converter.Convert(id);

            if(convertedId > 0) {
                value = new Some<string>(loader.Load(convertedId));
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
