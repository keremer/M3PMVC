@ModelType IEnumerable(Of TrimoryaMVC.Employment)

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
            @Html.DisplayNameFor(Function(model) model.IseGiris)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Istencikis)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.IseGirisNedeni)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.IstenCikisNedeni)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Görevi)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CalistigiProje)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CalistigiUlke)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Maasi)
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
            @Html.DisplayFor(Function(modelItem) currentItem.IseGiris)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Istencikis)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.IseGirisNedeni)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.IstenCikisNedeni)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Görevi)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.CalistigiProje)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.CalistigiUlke)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Maasi)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Notlar)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = currentItem.EUpdateId}) |
            @Html.ActionLink("Details", "Details", New With {.id = currentItem.EUpdateId}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = currentItem.EUpdateId})
        </td>
    </tr>
Next

</table>
