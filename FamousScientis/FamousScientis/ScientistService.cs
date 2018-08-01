using System;
using System.Collections.Generic;
using System.Linq;

namespace FamousScientis
{
    public class ScientistService
    {
        private Dictionary<string, Scientist> _dictionary;

        public ScientistService()
        {
            _dictionary = new Dictionary<string, Scientist>();
            PopulateScientists();
        }

        public Scientist GetScientistByName(string name)
        {
            Scientist scientist;
            if(_dictionary.TryGetValue(name, out scientist))
            {
                return scientist;
            }
            throw new ArgumentException("Unknown Scientist");
        }

        public IEnumerable<string> GetNames()
        {
            return _dictionary.Values.Select(scientist => scientist.Name);
        }

        private void PopulateScientists()
        {
            if (_dictionary == null)
            {
                _dictionary = new Dictionary<string, Scientist>();
            }

            var scientist = new Scientist
            {
                Name = "Sir Isaac Newton",
                ImagePath = "https://www.biographyonline.net/wp-content/uploads/2014/05/Sir_Isaac_Newton1.jpg",
                LifeSpan = "1642 - 1726",
                Description = "Newton was a polymath who made investigations into a whole range of subjects including mathematics, optics, physics, and astronomy. In his Principia Mathematica, published in 1687, he laid the foundations for classical mechanics, explaining the law of gravity and the laws of motion."
            };
            _dictionary.Add(scientist.Name, scientist);

            scientist = new Scientist
            {
                Name = "Louis Pasteur",
                ImagePath = "https://www.biographyonline.net/wp-content/uploads/2014/05/Louis_Pasteur.jpg",
                LifeSpan = "1822 - 1895",
                Description = "Pasteur contributed greatly towards the advancement of medical sciences developing cures for rabies, anthrax and other infectious diseases. Also invented the process of pasteurisation to make milk safer to drink. He probably saved more lives than any other person."
            };
            _dictionary.Add(scientist.Name, scientist);

            scientist = new Scientist
            {
                Name = "Galileo",
                ImagePath = "https://www.biographyonline.net/wp-content/uploads/2014/05/Galileo.jpg",
                LifeSpan = "1564 - 1642",
                Description = "Creating one of the first modern telescopes, Galileo revolutionised our understanding of the world, successfully proving the Earth revolves around the Sun and not the other way around. His work Two New Sciences laid the groundwork for the science of Kinetics and strength of materials."
            };
            _dictionary.Add(scientist.Name, scientist);

            scientist = new Scientist
            {
                Name = "Marie Curie",
                ImagePath = "https://www.biographyonline.net/wp-content/uploads/2014/05/Mariecurie.jpg",
                LifeSpan = "1867 - 1934",
                Description = "Polish physicist and chemist. Discovered radiation and helped to apply it in the field of X-ray. She won the Nobel Prize in both Chemistry and Physics."
            };
            _dictionary.Add(scientist.Name, scientist);

            scientist = new Scientist
            {
                Name = "Albert Einstein",
                ImagePath = "https://www.biographyonline.net/images/people/Einstein1921.jpg",
                LifeSpan = "1879 - 1955",
                Description = "Revolutionised modern physics with his general theory of relativity. He won the Nobel Prize in Physics (1921) for his discovery of the Photoelectric effect, which formed the basis of Quantum Theory."
            };
            _dictionary.Add(scientist.Name, scientist);

            scientist = new Scientist
            {
                Name = "Charles Darwin",
                ImagePath = "https://www.biographyonline.net/wp-content/uploads/2014/05/charles-darwin3.jpg",
                LifeSpan = "1809 - 1882",
                Description = "Darwin developed his theory of evolution against a backdrop of disbelief and scepticism. He collected evidence over 20 years and published his conclusions in On the Origin of Species (1859)."
            };
            _dictionary.Add(scientist.Name, scientist);

            scientist = new Scientist
            {
                Name = "Otto Hahn",
                ImagePath = "https://www.biographyonline.net/wp-content/uploads/2014/05/otto-hahn4.jpg",
                LifeSpan = "1879 - 1968",
                Description = "Hahn was a German chemist who discovered nuclear fission (1939). He was a pioneering scientist in the field of radiochemistry and discovered radioactive elements and nuclear isomerism (1921). He was awarded the Nobel Prize for Chemistry in 1944."
            };
            _dictionary.Add(scientist.Name, scientist);

            scientist = new Scientist
            {
                Name = "Nikola Tesla",
                ImagePath = "https://www.biographyonline.net/wp-content/uploads/2014/05/tesla3.jpg",
                LifeSpan = "1856 - 1943",
                Description = "Tesla worked on electromagnetism and AC current. He is credited with many patents from electricity to radio transmission and played a key role in the development of modern electricity."
            };
            _dictionary.Add(scientist.Name, scientist);

            scientist = new Scientist
            {
                Name = "James Clerk Maxwell",
                ImagePath = "https://www.biographyonline.net/wp-content/uploads/2014/05/James_clerk_maxwell4.jpg",
                LifeSpan = "1831 - 1879",
                Description = "Maxwell made great strides in understanding electromagnetism. His research in electricity and kinetics laid the foundation for quantum physics. Einstein said of Maxwell, “The work of James Clerk Maxwell changed the world forever.”"
            };
            _dictionary.Add(scientist.Name, scientist);

            scientist = new Scientist
            {
                Name = "Aristotle",
                ImagePath = "https://www.biographyonline.net/wp-content/uploads/2014/05/Aristotle_200.jpg",
                LifeSpan = "384 BCE - 322 BCE",
                Description = "A great early Greek scientist who made many types of research in the natural sciences including botany, zoology, physics, astronomy, chemistry, meteorology and geometry."
            };
            _dictionary.Add(scientist.Name, scientist);

            scientist = new Scientist
            {
                Name = "Michael Faraday",
                ImagePath = "https://www.biographyonline.net/wp-content/uploads/2014/05/michael-faraday4.jpg",
                LifeSpan = "1791 - 1867",
                Description = "English scientist who contributed to the fields of electromagnetic induction, diamagnetism, electrolysis and electrochemistry. Discovered Carbon and Chlorine."
            };
            _dictionary.Add(scientist.Name, scientist);

            scientist = new Scientist
            {
                Name = "Alexander Fleming",
                ImagePath = "https://www.biographyonline.net/wp-content/uploads/2014/05/fleming1.jpg",
                LifeSpan = "1881 - 1955",
                Description = "Scottish biologist who discovered penicillin. Shared Nobel Prize in 1945 with Howard Florey and Ernst Boris Chain, who helped produce penicillin on a large scale."
            };
            _dictionary.Add(scientist.Name, scientist);

            scientist = new Scientist
            {
                Name = "Dmitri Mendeleev",
                ImagePath = "https://www.biographyonline.net/wp-content/uploads/2014/06/dimitri-Mendeleev.jpg",
                LifeSpan = "1834 - 1907",
                Description = "Russian Chemist. Formulated the Periodic Law and standardised the Periodic Table of Elements which is still used today. Mendeleev wrote Principles of Chemistry (1868–1870) a classic textbook for many decades."
            };
            _dictionary.Add(scientist.Name, scientist);
        }
    }
}
