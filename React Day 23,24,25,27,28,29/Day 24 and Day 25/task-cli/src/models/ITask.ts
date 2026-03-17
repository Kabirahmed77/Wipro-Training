// src/models/ITask.ts
import { IUser } from "./IUser";  // <-- make sure this file exists!

export type TaskStatus = "Pending" | "Completed";

export interface ITask {
  id: number;
  title: string;
  status: TaskStatus;
  assignedTo?: IUser;
}