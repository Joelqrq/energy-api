namespace EnergyAPI.Models {
    public class EnergyGenerationFilter {
        public int? Year { get; set; }
        public string Region { get; set; }
        public decimal? Wind2 { get; set; }
        public decimal? WaveAndTidal { get; set; }
        public decimal? SolarPv { get; set; }
        public decimal? Hydro { get; set; }
        public decimal? LandfillGas { get; set; }
        public decimal? OtherBioEnergy { get; set; }
        public decimal? Total { get; set; }
    }
}
