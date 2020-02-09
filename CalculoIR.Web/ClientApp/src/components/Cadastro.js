import React, { Component } from 'react';
import axios from 'axios';
import InputMask from 'react-input-mask';
import { AgGridReact } from 'ag-grid-react';
import 'ag-grid-community/dist/styles/ag-grid.css';
import 'ag-grid-community/dist/styles/ag-theme-balham.css';

const URL = 'https://localhost:44334/api/Contribuintes/'

export class Cadastro extends Component {
    static displayName = Cadastro.name;


    constructor(props) {
        super(props);

        this.state = {
            Nome: "",
            Cpf: "",
            RendaMensal: "",
            QtdDependentes: "",
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
        this.enviarCadastro = this.enviarCadastro.bind(this);
        this.onChange = (evento) => {
            const state = Object.assign({}, this.state);
            const campo = evento.target.name;
            state[campo] = evento.target.value;
            this.setState(state);
        }
    }

    enviarCadastro() {

        let data = JSON.stringify({
            Nome: this.state.Nome,
            Cpf: this.state.Cpf,
            RendaMensal: this.state.RendaMensal,
            QtdDependentes: this.state.QtdDependentes
        })
        console.log(data);
        axios.post(URL, data, {
            headers: {
                'Content-Type': 'application/json',
            }})
            .then(response => {
                console.log(response.data);
            })
            .catch(erro => {
                console.log(erro);
            })


        axios.get(URL)
            .then(response => {
                const state = Object.assign({}, this.state);
                state.rowData = response.data;
                this.setState(state);
                console.log(response.data);
            })
            .catch(erro => {
                console.log(erro);
            });

        this.state.Nome = "";
        this.state.Cpf = "";
        this.state.RendaMensal = "";
        this.state.QtdDependentes = "";

    }

    render() {
        return (
            <div>
                <table>
                    <tr>
                        <td className="text-right label"> Nome: </td>
                        <td className="texto"><input className="texto" type="text" name="Nome" value={this.state.Nome} onChange={this.onChange} /></td>
                    </tr>
                    <tr>
                        <td className="text-right label"> CPF: </td>
                        <td className="texto"><InputMask className="texto" mask="999.999.999/99" type="text" name="Cpf" value={this.state.Cpf} onChange={this.onChange} /></td>
                    </tr>
                    <tr>
                        <td className="text-right label"> Renda Mensal: </td>
                        <td className="texto"><input className="texto" type="number" step="0.01" name="RendaMensal" value={this.state.RendaMensal} onChange={this.onChange} /></td>
                    </tr>
                    <tr>
                        <td className="text-right label"> Qtd. Dependentes: </td>
                        <td className="texto"><input className="texto" type="number" step="1" name="QtdDependentes" value={this.state.QtdDependentes} onChange={this.onChange} /></td>
                    </tr>
                    <tr>
                        <td> </td>
                        <td className="text-right">
                            <button className="btn btn-primary btn-sm" onClick={this.enviarCadastro}>Enviar</button>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
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
