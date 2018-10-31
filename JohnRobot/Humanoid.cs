namespace JohnRobot
{
    public class Humanoid
    {
        private readonly ISkill _skill;

        public Humanoid()
        {
        }

        public Humanoid(ISkill skill)

        {
            _skill = skill;
        }

        public string ShowSkill()
        {
            if (_skill == null)
            {
                return "no skill is defined";
            }
            return _skill.SkillName;
        }
    }
}