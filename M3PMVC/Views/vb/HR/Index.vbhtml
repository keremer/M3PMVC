@ModelType IEnumerable(Of TrimoryaMVC.HR)

@Code
    ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table>
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.KurumSicilNo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Ad)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Soyad)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Uyruk)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DogumTarihi)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PasaportNo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PasVerTarihi)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PasGecTarihi)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PasVerYeri)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.VizeTuru)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.IlkBasT)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CalismaKartiSure)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.SonCikT)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.SonCikNeden)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PersonelKademesi)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Notlar)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    Dim currentItem = item
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.KurumSicilNo)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Ad)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Soyad)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Uyruk)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.DogumTarihi)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.PasaportNo)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.PasVerTarihi)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.PasGecTarihi)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.PasVerYeri)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.VizeTuru)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.IlkBasT)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.CalismaKartiSure)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.SonCikT)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.SonCikNeden)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.PersonelKademesi)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Notlar)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = currentItem.TriMoryaId}) |
            @Html.ActionLink("Details", "Details", New With {.id = currentItem.TriMoryaId}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = currentItem.TriMoryaId})
        </td>
    </tr>
Next

</table>
