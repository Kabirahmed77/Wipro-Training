import { TaskManager } from "../services/TaskManager";
import type { IUser } from "../models/IUser";
import type { ITask } from "../models/ITask";

const manager = new TaskManager();
const args = process.argv.slice(2);
const command = args[0];

switch (command) {
  case "create-user": {
    const [name="", email=""] = args.slice(1);
    const user: IUser = { id: manager.getUsers().length + 1, name, email };
    manager.createUser(user);
    break;
  }
  case "create-task": {
    const title = args.slice(1).join(" ");
    const task: ITask = { id: manager.getTasks().length + 1, title, status: "Pending" };
    manager.createTask(task);
    break;
  }
  case "assign-task": {
    const taskId = Number(args[1]);
    const userId = Number(args[2]);
    manager.assignTask(taskId, userId);
    break;
  }
  case "list-tasks":
    manager.listTasks();
    break;
  case "complete-task": {
    const taskId = Number(args[1]);
    manager.completeTask(taskId);
    break;
  }
  default:
    console.log("Invalid command");
}