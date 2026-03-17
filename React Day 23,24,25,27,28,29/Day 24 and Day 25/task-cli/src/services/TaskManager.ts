import { IUser } from "../models/IUser";
import { ITask, TaskStatus } from "../models/ITask";

export class TaskManager {
    private users: IUser[] = [];
    private tasks: ITask[] = [];

    createUser(user: IUser): void {
        this.users.push(user);
        console.log(`User created: ${user.name}`);
    }

    createTask(task: ITask): void {
        this.tasks.push(task);
        console.log(`Task created: ${task.title}`);
    }

    assignTask(taskId: number, userId: number): void {
        const task = this.tasks.find(t => t.id === taskId);
        const user = this.users.find(u => u.id === userId);

        if (task && user) {
            task.assignedTo = user;
            console.log(`Task assigned to ${user.name}`);
        } else {
            console.log("Task or user not found");
        }
    }

   listTasks(): void {
  this.tasks.forEach(task => {
    const assigned = task.assignedTo ? task.assignedTo.name : "Unassigned";
    console.log(`${task.id}: ${task.title} [${task.status}] - Assigned to: ${assigned}`);
  });
}
    completeTask(taskId: number): void {
        const task = this.tasks.find(t => t.id === taskId);
        if (task) {
            task.status = "Completed";
            console.log("Task marked as completed");
        } else {
            console.log("Task not found");
        }
    }

    // --- ADDED THESE NEW METHODS ---
    getUsers(): IUser[] {
        return this.users;
    }

    getTasks(): ITask[] {
        return this.tasks;
    }
}