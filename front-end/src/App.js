import React, { Component } from 'react';
import Navbar from './navbar';
import "@blueprintjs/core/lib/css/blueprint.css";
import "@blueprintjs/icons/lib/css/blueprint-icons.css";
import CarsPage from "./main-pages/cars";
import EmployeesPage from "./main-pages/employees";
import DealershipsPage from "./main-pages/dealerships";
import CustomersPage from "./main-pages/customers";

class App extends Component {
  constructor(props) {
    super(props);
    this.state = {
      activeTab: "cars"
    }
  }
  changeTab(val) {
    this.setState({ activeTab: val })
  }
  render() {
    let body = null
    switch(this.state.activeTab) {
      case 'cars':
        body = <CarsPage />
        break
      case 'employees':
        body = <EmployeesPage />
        break
      case 'dealerships':
        body = <DealershipsPage />
        break
      case 'customers':
        body = <CustomersPage />
        break
    }
    return (
      <div id="app">
        <Navbar
          changeTab={this.changeTab.bind(this)}
        />
        <body>
          { body }
        </body>
      </div>
    );
  }
}

export default App;
