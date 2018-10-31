namespace JohnRobot
{
    internal class Cooking : ISkill
    {
        public string SkillName { get; set; }

        public Cooking()
        {
            this.SkillName = "cooking";
        }
    }
}