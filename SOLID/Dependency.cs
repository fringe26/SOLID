using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Dependency
    {
        private ISoundManager _soundManager;

        public Dependency(ISoundManager soundManager)
        {
            _soundManager = soundManager;
        }

        public void AttackSound()
        {
            _soundManager.Play("Attack");
        }
    }

    public interface ISoundManager
    {
        void Play(string name);
    }


    public class MyNewSoundManager : ISoundManager
    {
        public void Play(string name)
        {
            throw new NotImplementedException();
        }
    }

 
}
