@ModelType TrimoryaMVC.Employment

@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<fieldset>
    <legend>Employment</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.KurumSicilNo)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.KurumSicilNo)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.IseGiris)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.IseGiris)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Istencikis)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Istencikis)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.IseGirisNedeni)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.IseGirisNedeni)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.IstenCikisNedeni)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.IstenCikisNedeni)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Görevi)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Görevi)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.CalistigiProje)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.CalistigiProje)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.CalistigiUlke)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.CalistigiUlke)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Maasi)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Maasi)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Notlar)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Notlar)
    </div>
</fieldset>
@Using Html.BeginForm()
    @<p>
        <input type="submit" value="Delete" /> |
        @Html.ActionLink("Back to List", "Index")
    </p>
End Using
