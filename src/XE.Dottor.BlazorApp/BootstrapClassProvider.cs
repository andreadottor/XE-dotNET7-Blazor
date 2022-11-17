namespace XE.Dottor.BlazorApp;

using Microsoft.AspNetCore.Components.Forms;

public class BootstrapClassProvider : FieldCssClassProvider
{
    public override string GetFieldCssClass(EditContext editContext, in FieldIdentifier fieldIdentifier)
    {
        var isValid = !editContext.GetValidationMessages(fieldIdentifier).Any();
        if (editContext.IsModified(fieldIdentifier))
        {
            return isValid ? "is-valid" : "is-invalid";
        }
        else
        {
            return isValid ? "" : "is-invalid";
        }
    }
}