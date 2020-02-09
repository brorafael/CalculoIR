import React, { Component } from 'react';
import axios from 'axios';
import { AgGridReact } from 'ag-grid-react';
import 'ag-grid-community/dist/styles/ag-grid.css';
import 'ag-grid-community/dist/styles/ag-theme-balham.css';

const URL = 'https://localhost:44334/api/Contribuintes'//https://localhost:44334/api/CalculoIR/'

export class Calculo extends Component {
    static displayName = Calculo.name;


    constructor(props) {
        super(props);

        this.state = {
            valorSalarioMinimo: "",
            columnDefs: [{
                headerName: "Nome", field: "nome"
            }, {
                headerName: "CPF", field: "cpf"
            }, {
                headerName: "Renda Mensal", field: "rendaMensal"
            }, {
                headerName: "Qtd. Dependentes", field: "qtdDependentes"
            }],
            rowData: []
        };

        this.calcular = this.calcular.bind(this);

        this.onChange = (evento) => {
            const state = Object.assign({}, this.state);
            const campo = evento.target.name;
            state[campo] = evento.target.value;
            this.setState(state);
        }
    }

    calcular() {
        //axios.get(URL)
        //    .then(response => {
        //        const state = Object.assign({}, this.state);
        //        state.rowData = response.data;
        //        this.setState(state);
        //        console.log(response.data);
        //    })
        //    .catch(erro => {
        //        console.log(erro);
        //    })

        let data = JSON.stringify({
            valorSalarioMinimo: this.state.valorSalarioMinimo,
        })
        console.log(data);
        axios.post(URL, data, {
            headers: {
                'Content-Type': 'application/json',
            }
        })
            .then(response => {
                const state = Object.assign({}, this.state);
                state.rowData = response.data;
                this.setState(state);
                console.log(response.data);
            })
            .catch(erro => {
                console.log(erro);
            })

        this.valorSalarioMinimo = "";
    }

    render() {
        return (
            <div>
                <table>
                    <tr>
                        <td className="label"> Salario Minimo: </td>
                        <td className="texto"><input className="texto" type="number" step="0.01" name="valorSalarioMinimo" value={this.state.valorSalarioMinimo} onChange={this.onChange} /></td>
                        <td>
                            <button className="btn btn-primary btn-sm" onClick={this.calcular}>Calcular</button>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <div
                                className="ag-theme-balham"
                                style={{
                                    height: '300px',
                                    width: '100%'
                                }}
                            >
                                <AgGridReact
                                    columnDefs={this.state.columnDefs}
                                    rowData={this.state.rowData}>
                                </AgGridReact>
                            </div>
                        </td>
                    </tr>
                </table>
            </div>
        );
    }
}
