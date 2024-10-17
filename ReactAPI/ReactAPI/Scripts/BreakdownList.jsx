class BreakdownList extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            breakdowns: []  
        };
    }

    componentDidMount() {
        axios.get('/Home/GetBreakdownsList')
            .then(response => {
                this.setState({ breakdowns: response.data });
            })
            .catch(error => {
                console.error('Error fetching breakdowns:', error);
            });
    }

    render() {
        return (
            <div>
                <h1>Breakdown List</h1>
                <ul>
                    {}
                    {this.state.breakdowns.map(breakdown => (
                        <li key={breakdown.Id}>
                            {breakdown.BreakdownReference} - {breakdown.CompanyName}
                        </li>
                    ))}
                </ul>
            </div>
        );
    }
}

ReactDOM.render(<BreakdownList />, document.getElementById('breakdown-list'));
