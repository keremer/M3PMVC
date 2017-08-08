@ModelType TrimoryaMVC.Employment

@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
<p>

    @Html.ActionLink("Edit", "Edit", New With {.id = Model.EUpdateId}) |
    @Html.ActionLink("Back to List", "Index")
</p>
