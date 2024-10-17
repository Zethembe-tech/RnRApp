import React, { useState } from 'react';
import axios from 'axios';

const BreakdownForm = () => {
    const [breakdown, setBreakdown] = useState({
        BreakdownReference: '',
        CompanyName: '',
        DriverName: '',
        RegistrationNumber: '',
        BreakdownDate: ''
    });

    const handleChange = (e) => {
        const { name, value } = e.target;
        setBreakdown({
            ...breakdown,
            [name]: value
        });
    };

    const handleSubmit = async (e) => {
        e.preventDefault();
        try {
            // Send POST request to create breakdown
            const response = await axios.post('/Home/Create', breakdown);
            alert(response.data);  // Show success or failure message
            // Optionally reset the form
            setBreakdown({
                BreakdownReference: '',
                CompanyName: '',
                DriverName: '',
                RegistrationNumber: '',
                BreakdownDate: ''
            });
        } catch (error) {
            console.error('Error creating breakdown', error);
            alert('Error creating breakdown');
        }
    };

    return (
        <div>
            <form onSubmit={handleSubmit}>
                <div>
                    <label>Breakdown Reference</label>
                    <input
                        type="text"
                        name="BreakdownReference"
                        value={breakdown.BreakdownReference}
                        onChange={handleChange}
                        required
                    />
                </div>
                <div>
                    <label>Company Name</label>
                    <input
                        type="text"
                        name="CompanyName"
                        value={breakdown.CompanyName}
                        onChange={handleChange}
                        required
                    />
                </div>
                <div>
                    <label>Driver Name</label>
                    <input
                        type="text"
                        name="DriverName"
                        value={breakdown.DriverName}
                        onChange={handleChange}
                        required
                    />
                </div>
                <div>
                    <label>Registration Number</label>
                    <input
                        type="text"
                        name="RegistrationNumber"
                        value={breakdown.RegistrationNumber}
                        onChange={handleChange}
                        required
                    />
                </div>
                <div>
                    <label>Breakdown Date</label>
                    <input
                        type="date"
                        name="BreakdownDate"
                        value={breakdown.BreakdownDate}
                        onChange={handleChange}
                        required
                    />
                </div>
                <button type="submit">Create</button>
            </form>
        </div>
    );
};

export default BreakdownForm;
