import { TaskManager } from "../src/services/TaskManager";

describe("TaskManager", () => {
  let manager: TaskManager;

  beforeEach(() => {
    manager = new TaskManager();
  });

  test("should create a task", () => {
    manager.createTask({ id: 1, title: "Build API", status: "Pending" });
    expect(manager.getTasks().length).toBe(1);
  });

  test("should complete a task", () => {
    manager.createTask({ id: 1, title: "Build API", status: "Pending" });
    manager.completeTask(1);
    expect(manager.getTasks()[0]!.status).toBe("Completed");
  });

  test("should assign task to a user", () => {
    manager.createUser({ id: 1, name: "Rahul", email: "rahul@email.com" });
    manager.createTask({ id: 1, title: "Build API", status: "Pending" });
    manager.assignTask(1, 1);
    expect(manager.getTasks()[0]!.assignedTo?.name).toBe("Rahul");
  });
});