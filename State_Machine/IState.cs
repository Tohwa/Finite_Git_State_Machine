using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IStates
{
    public void EnterState();
    
    public void UpdateState();

    public IStates CheckState();

    public void ExitState();
}

