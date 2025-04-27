using Microsoft.AspNetCore.Components;

namespace GearGrid.Components.Pages;

public partial class Counter : ComponentBase
{
    int currentCount;
    bool showMessage;

    async Task IncrementCount()
    {
        currentCount++;
        if (currentCount >= 10)
        {
            await ShowTemporaryMessage();
        }
    }
    
    async Task ShowTemporaryMessage()
    {
        showMessage = true;
    
        // Wait for 2 seconds
        await Task.Delay(2000);

        showMessage = false;
    }

}