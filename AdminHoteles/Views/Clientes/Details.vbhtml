@ModelType AdminHoteles.Cliente
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Cliente</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.nombresCliente)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.nombresCliente)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.apellidosCliente)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.apellidosCliente)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.numeroIdentificacionCliente)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.numeroIdentificacionCliente)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.tipoIdentificacionCliente)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tipoIdentificacionCliente)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.clienteId }) |
    @Html.ActionLink("Back to List", "Index")
</p>
