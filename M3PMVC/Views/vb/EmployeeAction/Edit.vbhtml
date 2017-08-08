@ModelType TrimoryaMVC.Employment

@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using Html.BeginForm()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>Employment</legend>

        @Html.HiddenFor(Function(model) model.EUpdateId)

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.KurumSicilNo)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.KurumSicilNo)
            @Html.ValidationMessageFor(Function(model) model.KurumSicilNo)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.IseGiris)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.IseGiris)
            @Html.ValidationMessageFor(Function(model) model.IseGiris)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Istencikis)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Istencikis)
            @Html.ValidationMessageFor(Function(model) model.Istencikis)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.IseGirisNedeni)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.IseGirisNedeni)
            @Html.ValidationMessageFor(Function(model) model.IseGirisNedeni)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.IstenCikisNedeni)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.IstenCikisNedeni)
            @Html.ValidationMessageFor(Function(model) model.IstenCikisNedeni)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Görevi)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Görevi)
            @Html.ValidationMessageFor(Function(model) model.Görevi)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.CalistigiProje)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.CalistigiProje)
            @Html.ValidationMessageFor(Function(model) model.CalistigiProje)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.CalistigiUlke)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.CalistigiUlke)
            @Html.ValidationMessageFor(Function(model) model.CalistigiUlke)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Maasi)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Maasi)
            @Html.ValidationMessageFor(Function(model) model.Maasi)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Notlar)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Notlar)
            @Html.ValidationMessageFor(Function(model) model.Notlar)
        </div>

        <p>
            <input type="submit" value="Save" />
        </p>
    </fieldset>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
