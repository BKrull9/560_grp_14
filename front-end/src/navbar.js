import React, { Component } from 'react';
import { 
    Button,
    Classes,
    Navbar,
    NavbarHeading,
    NavbarDivider,
    NavbarGroup
} from '@blueprintjs/core';

export default class NavBar extends Component {
    render() {
      return (
        <div className="App">
          <nav className="bp3-navbar bp3-dark">
            <div style={{margin: '0 auto', width: '50%'}}>
              <div className="bp3-navbar-group bp3-align-left">
                <div className="bp3-navbar-heading">Cars N Stuff</div>
              </div>
              <div className="bp3-navbar-group bp3-align-right">
                <button
                    onClick={() => this.props.changeTab('cars')}
                    className="bp3-button bp3-minimal bp3-icon-drive-time"
                >Cars</button>
                <button
                    onClick={() => this.props.changeTab('employees')}
                    className="bp3-button bp3-minimal bp3-icon-person"
                >Employees</button>
                <button
                    onClick={() => this.props.changeTab('dealerships')}
                    className="bp3-button bp3-minimal bp3-icon-office">Dealerships</button>
                <button
                    onClick={() => this.props.changeTab('customers')}
                    className="bp3-button bp3-minimal bp3-icon-user">Customers</button>
              </div>
            </div>
          </nav>
        </div>
      );
    }
  }