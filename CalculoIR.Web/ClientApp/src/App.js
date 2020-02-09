import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Calculo } from './components/Calculo';
import { Cadastro } from './components/Cadastro';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/Cadastro' component={Cadastro} />
        <Route path='/Calculo' component={Calculo} />
      </Layout>
    );
  }
}
