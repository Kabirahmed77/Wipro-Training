import React, { Component, createRef } from "react";
class StockDashboard extends Component {
constructor(){
super();

this.state = {
stockSymbol: "",
price: ""
};

this.previousSearch = createRef();
}

componentDidMount(){
console.log("Dashboard Loaded");
}

handleChange = (e) => {
this.setState({
stockSymbol: e.target.value
});
}

getPrice = () => {

const randomPrice = (Math.random()*1000).toFixed(2);

this.setState({
price: randomPrice
});

this.previousSearch.current.value += this.state.stockSymbol + " ";
}

render(){

return(

<div className="container mt-5">

<h2 className="text-center text-primary">
Stock Market Dashboard
</h2>

<div className="card p-4 shadow">

<input
type="text"
className="form-control mb-3"
placeholder="Enter Stock Symbol"
value={this.state.stockSymbol}
onChange={this.handleChange}
/>

<button
className="btn btn-success"
onClick={this.getPrice}
>
Get Stock Price
</button>

<h4 className="mt-3">
Price: {this.state.price}
</h4>

<h5 className="mt-3">Previous Searches</h5>

<textarea
ref={this.previousSearch}
className="form-control"
/>

</div>

</div>
);
}
}

export default StockDashboard;