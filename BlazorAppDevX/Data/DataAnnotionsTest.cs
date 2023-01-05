using System.ComponentModel.DataAnnotations;

namespace BlazorAppDevX.Data
{
    public class DataAnnotionsTest
    {
        //NOTE: having the ()_{} in the error message string causes an exception noted below
        /*
         * 
         * [2022-12-15T14:44:10.818Z] Error: System.FormatException: Input string was not in a correct format.
   at System.Text.ValueStringBuilder.ThrowFormatError()
   at System.Text.ValueStringBuilder.AppendFormatHelper(IFormatProvider provider, String format, ParamsArray args)
   at System.String.FormatHelper(IFormatProvider provider, String format, ParamsArray args)
   at System.String.Format(IFormatProvider provider, String format, Object arg0, Object arg1)
   at System.ComponentModel.DataAnnotations.RegularExpressionAttribute.FormatErrorMessage(String name)
   at System.ComponentModel.DataAnnotations.ValidationAttribute.IsValid(Object value, ValidationContext validationContext)
   at System.ComponentModel.DataAnnotations.ValidationAttribute.GetValidationResult(Object value, ValidationContext validationContext)
   at System.ComponentModel.DataAnnotations.Validator.TryValidate(Object value, ValidationContext validationContext, ValidationAttribute attribute, ValidationError& validationError)
   at System.ComponentModel.DataAnnotations.Validator.GetValidationErrors(Object value, ValidationContext validationContext, IEnumerable`1 attributes, Boolean breakOnFirstError)
   at System.ComponentModel.DataAnnotations.Validator.TryValidateProperty(Object value, ValidationContext validationContext, ICollection`1 validationResults)
   at Microsoft.AspNetCore.Components.Forms.EditContextDataAnnotationsExtensions.DataAnnotationsEventSubscriptions.OnFieldChanged(Object sender, FieldChangedEventArgs eventArgs)
   at Microsoft.AspNetCore.Components.Forms.EditContext.NotifyFieldChanged(FieldIdentifier& fieldIdentifier)
   at DevExpress.Blazor.Internal.DxEditorBase`2.OnValueChangedInternal()
   at DevExpress.Blazor.Base.DxTextEditorBase.OnValueChangedInternal()
   at DevExpress.Blazor.Internal.InputAttributesHelper.<>c__DisplayClass9_0`1.<<GetEventWithUserEvent>b__0>d.MoveNext()
--- End of stack trace from previous location ---
   at Microsoft.AspNetCore.Components.ComponentBase.CallStateHasChangedOnAsyncCompletion(Task task)
   at Microsoft.AspNetCore.Components.RenderTree.Renderer.GetErrorHandledTask(Task taskToHandle, ComponentState owningComponentState)
         */
        [RegularExpression(@"^[a-zA-Z0-9()_{}|\\/,.:;' -]*$", ErrorMessage = "Only Alpha numeric and the following special characters allowed: ()_{}|\\/,.:;'-")]
        public string? PropertyWithRegXMessageCausingException { get;
            set; }

        [RegularExpression(@"^[a-zA-Z0-9()_{}|\\/,.:;' -]*$", ErrorMessage = "Only Alpha numeric and the following special characters allowed: _|\\/,.:;'-")]
        public string? PropertyWithRegXMessageThatWorks { get; set; }
    }
}
