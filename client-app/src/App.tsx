import React, { Component } from "react";
import '@progress/kendo-theme-default/dist/all.css';
import "./App.css";
import { Header, Icon } from 'semantic-ui-react'
import { Editor, EditorTools } from '@progress/kendo-react-editor';






class App extends Component {


  render() {
    return (
      <div>
      <Header as='h2'>
      <Icon name='users' />
      <Header.Content>Reactivities</Header.Content>
    </Header>
    </div>
    );
  }
}



export default App;
