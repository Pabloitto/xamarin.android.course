using System.Collections.Generic;

namespace RaysTest.Core.Model
{
    public class HotDogGroup
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public List<HotDog> HotDogs { get; set; }
    }
}
