var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
class BillingManager {
    constructor() {
        this.apiUrl = "http://localhost:5147/api/invoices";
        this.bindEvents();
        this.fetchInvoices();
    }
    bindEvents() {
        const invForm = document.getElementById('invoiceForm');
        invForm === null || invForm === void 0 ? void 0 : invForm.addEventListener('submit', (e) => __awaiter(this, void 0, void 0, function* () {
            e.preventDefault();
            yield this.handleAction('POST', this.getInvoiceData(), () => this.fetchInvoices());
        }));
        const custForm = document.getElementById('customerForm');
        custForm === null || custForm === void 0 ? void 0 : custForm.addEventListener('submit', (e) => __awaiter(this, void 0, void 0, function* () {
            e.preventDefault();
            yield this.handleAction('POST/customer', this.getCustomerData(), () => alert("Customer Registered Successfully!"));
        }));
    }
    getInvoiceData() {
        return {
            CustomerId: parseInt(document.getElementById('custId').value),
            Amount: parseFloat(document.getElementById('amount').value),
            DueDate: document.getElementById('dueDate').value,
            // UPDATED: Grabs the choice from the new dropdown
            Status: document.getElementById('statusSelect').value
        };
    }
    getCustomerData() {
        return {
            Id: parseInt(document.getElementById('newCustId').value),
            Name: document.getElementById('newCustName').value
        };
    }
    handleAction(type, data, callback) {
        return __awaiter(this, void 0, void 0, function* () {
            let targetUrl = this.apiUrl;
            if (type.includes('/')) {
                targetUrl = this.apiUrl + "/customer";
            }
            try {
                const res = yield fetch(targetUrl, {
                    method: 'POST',
                    headers: { 'Content-Type': 'application/json' },
                    body: JSON.stringify(data)
                });
                if (res.ok) {
                    callback();
                    const formSelector = type.includes('/') ? '#customerForm' : '#invoiceForm';
                    document.querySelector(formSelector).reset();
                }
                else {
                    const error = yield res.text();
                    alert("Server Error: " + error);
                }
            }
            catch (e) {
                alert("Backend Offline. Check if 'dotnet run' is active.");
            }
        });
    }
    fetchInvoices() {
        return __awaiter(this, void 0, void 0, function* () {
            try {
                const res = yield fetch(this.apiUrl);
                const data = yield res.json();
                this.renderTable(data);
            }
            catch (e) {
                console.error("Fetch failed", e);
            }
        });
    }
    renderTable(invoices) {
        const tbody = document.getElementById('invoiceTableBody');
        if (!tbody)
            return;
        tbody.innerHTML = invoices.map(inv => {
            // Logic to choose badge color based on status
            const status = inv.status || inv.Status;
            let badgeClass = "bg-success"; // Default green
            if (status === "Pending")
                badgeClass = "bg-warning text-dark";
            if (status === "Overdue")
                badgeClass = "bg-danger";
            if (status === "Cancelled")
                badgeClass = "bg-secondary";
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
