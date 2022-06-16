using backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider> Sliders { get; set; }
        public SliderSummary SliderSummary { get; set; }
        public WorkSummary WorkSummary { get; set; }
        public List<WorkSlider> WorkSliders { get; set; }
        public List<News> News { get; set; }
        public List<Testimonials> Testimonials { get; set; }
        public List<Summary> Summaries { get; set; }
    }
}
