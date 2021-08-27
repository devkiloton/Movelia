using Movelia.Shared.Entities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movelia.Client.Pages
{
    public partial class Counter
    {
    [Inject] SingletonService singleton { get; set; }
    [Inject] TransientService transient { get; set; }

    private int currentCount = 0;

    private void IncrementCount()
        {
            currentCount++;
            singleton.Value++;
            transient.Value++;
        }
    }
}
