namespace oop_adventure.Actions
{
    public abstract class Action
    {
        public virtual string Name => "";

        public virtual void Execute(string[] args)
        {
            throw new Exception("Nothing to execute");
        }
    }
}