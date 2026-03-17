interface BillingInvoice {
    InvoiceId?: number; 
    CustomerId: number;
    Amount: number;
    DueDate: string;
    Status: string;
}

class BillingManager {
    private apiUrl: string = "http://localhost:5147/api/invoices";

    constructor() {
        this.bindEvents();
        this.fetchInvoices();
    }

    private bindEvents(): void {
        const invForm = document.getElementById('invoiceForm') as HTMLFormElement;
        invForm?.addEventListener('submit', async (e) => {
            e.preventDefault();
            await this.handleAction('POST', this.getInvoiceData(), () => this.fetchInvoices());
        });

        const custForm = document.getElementById('customerForm') as HTMLFormElement;
        custForm?.addEventListener('submit', async (e) => {
            e.preventDefault();
            await this.handleAction('POST/customer', this.getCustomerData(), () => alert("Customer Registered Successfully!"));
        });
    }

    private getInvoiceData() {
        return {
            CustomerId: parseInt((document.getElementById('custId') as HTMLInputElement).value),
            Amount: parseFloat((document.getElementById('amount') as HTMLInputElement).value),
            DueDate: (document.getElementById('dueDate') as HTMLInputElement).value,
            // UPDATED: Grabs the choice from the new dropdown
            Status: (document.getElementById('statusSelect') as HTMLSelectElement).value 
        };
    }

    private getCustomerData() {
        return {
            Id: parseInt((document.getElementById('newCustId') as HTMLInputElement).value),
            Name: (document.getElementById('newCustName') as HTMLInputElement).value
        };
    }

    private async handleAction(type: string, data: any, callback: Function) {
        let targetUrl = this.apiUrl;
        if (type.includes('/')) {
            targetUrl = this.apiUrl + "/customer";
        }
        
        try {
            const res = await fetch(targetUrl, {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify(data)
            });
            if (res.ok) {
                callback();
                const formSelector = type.includes('/') ? '#customerForm' : '#invoiceForm';
                (document.querySelector(formSelector) as HTMLFormElement).reset();
            } else {
                const error = await res.text();
                alert("Server Error: " + error);
            }
        } catch (e) { 
            alert("Backend Offline. Check if 'dotnet run' is active."); 
        }
    }

    public async fetchInvoices() {
        try {
            const res = await fetch(this.apiUrl);
            const data = await res.json();
            this.renderTable(data);
        } catch (e) {
            console.error("Fetch failed", e);
        }
    }

    private renderTable(invoices: any[]) {
        const tbody = document.getElementById('invoiceTableBody');
        if (!tbody) return;
        
        tbody.innerHTML = invoices.map(inv => {
            // Logic to choose badge color based on status
            const status = inv.status || inv.Status;
            let badgeClass = "bg-success"; // Default green
            
            if (status === "Pending") badgeClass = "bg-warning text-dark";
            if (status === "Overdue") badgeClass = "bg-danger";
            if (status === "Cancelled") badgeClass = "bg-secondary";

            return `
                <tr>
                    <td class="ps-3 fw-bold">INV-${inv.invoiceId || inv.InvoiceId}</td>
                    <td>CUST-${inv.customerId || inv.CustomerId}</td>
                    <td>$${parseFloat(inv.amount || inv.Amount).toFixed(2)}</td>
                    <td>${new Date(inv.dueDate || inv.DueDate).toLocaleDateString()}</td>
                    <td><span class="badge ${badgeClass}">${status}</span></td>
                </tr>
            `;
        }).join('');
    }
}

document.addEventListener('DOMContentLoaded', () => new BillingManager());