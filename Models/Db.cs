namespace mvcDotNetTrainingGround.Models
{
    public class Db
    {
        public Db()
        {
            Developers = new List<Developer>()
            {
            new Developer() { Id = 1, Name = "Marcus", Role = "DevOps Engineer", Experience = 5 },
            new Developer() { Id = 2, Name = "Beatrice", Role = "Frontend Developer", Experience = 3 },
            new Developer() { Id = 3, Name = "Liam", Role = "Backend Developer", Experience = 4 },
            new Developer() { Id = 4, Name = "Sophia", Role = "Full Stack Developer", Experience = 6 },
            };
        }
        public List<Developer> Developers { get; set; }
    }
}