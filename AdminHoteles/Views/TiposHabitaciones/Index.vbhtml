@ModelType IEnumerable(Of AdminHoteles.TipoHabitacion)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.nombreTipoHabitacion)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.nombreTipoHabitacion)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.tipoHabitacionId }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.tipoHabitacionId }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.tipoHabitacionId })
        </td>
    </tr>
Next

</table>
