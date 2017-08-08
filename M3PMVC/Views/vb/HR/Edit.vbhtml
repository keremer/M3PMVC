@ModelType TrimoryaMVC.HR

@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using Html.BeginForm()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>HR</legend>

        @Html.HiddenFor(Function(model) model.TriMoryaId)

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.KurumSicilNo)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.KurumSicilNo)
            @Html.ValidationMessageFor(Function(model) model.KurumSicilNo)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Ad)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Ad)
            @Html.ValidationMessageFor(Function(model) model.Ad)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Soyad)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Soyad)
            @Html.ValidationMessageFor(Function(model) model.Soyad)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Uyruk)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Uyruk)
            @Html.ValidationMessageFor(Function(model) model.Uyruk)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.DogumTarihi)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.DogumTarihi)
            @Html.ValidationMessageFor(Function(model) model.DogumTarihi)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.PasaportNo)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.PasaportNo)
            @Html.ValidationMessageFor(Function(model) model.PasaportNo)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.PasVerTarihi)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.PasVerTarihi)
            @Html.ValidationMessageFor(Function(model) model.PasVerTarihi)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.PasGecTarihi)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.PasGecTarihi)
            @Html.ValidationMessageFor(Function(model) model.PasGecTarihi)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.PasVerYeri)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.PasVerYeri)
            @Html.ValidationMessageFor(Function(model) model.PasVerYeri)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.VizeTuru)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.VizeTuru)
            @Html.ValidationMessageFor(Function(model) model.VizeTuru)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.IlkBasT)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.IlkBasT)
            @Html.ValidationMessageFor(Function(model) model.IlkBasT)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.CalismaKartiSure)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.CalismaKartiSure)
            @Html.ValidationMessageFor(Function(model) model.CalismaKartiSure)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.SonCikT)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.SonCikT)
            @Html.ValidationMessageFor(Function(model) model.SonCikT)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.SonCikNeden)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.SonCikNeden)
            @Html.ValidationMessageFor(Function(model) model.SonCikNeden)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.PersonelKademesi)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.PersonelKademesi)
            @Html.ValidationMessageFor(Function(model) model.PersonelKademesi)
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
