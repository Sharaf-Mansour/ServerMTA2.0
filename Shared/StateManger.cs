using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMTA.Shared
{
    public class StateManger
    {
        public int Score { get; set; } = 0;
        public event Action OnChange;
        public void SetScore(int value)
        {
            Score = value;
            NotifyStateChanged();
        }
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
