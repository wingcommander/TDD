using System;

namespace TddMockPractice
{
    public class FileRepository
    {
        public void Save(string data)
        {
            
        }

        public virtual string Load(string name)
        {
            return "01/01/1973";
        }
    }

    public class MockFileRepository :FileRepository
    {
        public override string Load(string name)
        {
            
            return "01/01/2000";
        }
    }

    public class InteractionRepository : FileRepository
    {
        public override string Load(string name)
        {
            if (name != "Garvan") throw new NotImplementedException();
            return "";
        }
    }


}