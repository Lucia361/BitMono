using BitMono.API.Protections;

namespace BitMono.GUI.Pages.Obfuscation;

public partial class Protections
{
    [Inject] public IJSRuntime JSRuntime { get; set; }
    [Inject] public ICollection<IProtection> RegisteredProtections { get; set; }
    [Inject] public IStoringProtections StoringProtections { get; set; }


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JSRuntime.AddTooltipsAsync();
    }

    public void EnableAll()
    {
        foreach (var protectionSettings in StoringProtections.Protections)
        {
            protectionSettings.Enable();
        }
    }
    public void DisableAll()
    {
        foreach (var protectionSettings in StoringProtections.Protections)
        {
            protectionSettings.Disable();
        }
    }
    public void MoveUp(ProtectionSetting protectionSetting)
    {
        var index = StoringProtections.Protections.IndexOf(protectionSetting);
        StoringProtections.Protections.Swap(index, index - 1);
    }
    public void MoveDown(ProtectionSetting protectionSetting)
    {
        var index = StoringProtections.Protections.IndexOf(protectionSetting);
        StoringProtections.Protections.Swap(index, index + 1);
    }
}