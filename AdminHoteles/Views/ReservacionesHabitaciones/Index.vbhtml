@ModelType IEnumerable(Of AdminHoteles.ReservacionHabitacion)
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
            @Html.DisplayNameFor(Function(model) model.habitacionId)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.clienteId)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.desde)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.hasta)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.precioAcordado)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.habitacionId)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.clienteId)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.desde)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.hasta)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.precioAcordado)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.reservacionHabitacionId }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.reservacionHabitacionId }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.reservacionHabitacionId })
        </td>
    </tr>
Next

</table>
