@ModelType TrimoryaMVC.HR

@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<fieldset>
    <legend>HR</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.KurumSicilNo)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.KurumSicilNo)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Ad)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Ad)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Soyad)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Soyad)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Uyruk)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Uyruk)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.DogumTarihi)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.DogumTarihi)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.PasaportNo)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.PasaportNo)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.PasVerTarihi)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.PasVerTarihi)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.PasGecTarihi)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.PasGecTarihi)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.PasVerYeri)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.PasVerYeri)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.VizeTuru)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.VizeTuru)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.IlkBasT)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.IlkBasT)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.CalismaKartiSure)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.CalismaKartiSure)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.SonCikT)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.SonCikT)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.SonCikNeden)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.SonCikNeden)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.PersonelKademesi)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.PersonelKademesi)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Notlar)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Notlar)
    </div>
</fieldset>
<p>

    @Html.ActionLink("Edit", "Edit", New With {.id = Model.TriMoryaId}) |
    @Html.ActionLink("Back to List", "Index")
</p>
