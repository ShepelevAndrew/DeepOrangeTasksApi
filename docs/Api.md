# DeepOrangeApi

- [DeepOrangeTasksApi](#deep-orange-api)
    - [Tasks](#tasks)
        - [Create](#create)
            - [Create Request](#create-request)
            - [Create Response](#create-response)
        - [Get](#get)
            - [Get Response](#get-response)
        - [Get one](#get-one)
            - [Get one Response](#get-one-response)
        - [Update one](#update)
            - [Update one Request](#update-one-request)
            - [Update one Response](#update-one-response)
        - [Patch one](#patch-one)
            - [Patch one Request](#patch-one-request)
            - [Patch one Response](#patch-one-response)
        - [Delete one](#delete-one)
            - [Delete one Response](#delete-one-response)

## Tasks

### Create

```js
POST {{host}}/api/v1.0/tasks
```

### Create Request

```json
{
    "title": "Title bug in DeepOrangeTasksApi",
    "content": {
        "text": "There is bug with tasks, when you change title it returns 404 code in response",
        "photos": [
            "photo1.png", "photo2.png", "photo3.png"
        ],
        "videos": [
            "video1.mp4"
        ]
    }
}
```

### Create Response

```js
201 Created
```

```json
{
    "id": "d800dio3-spo3-b4893-jdsfk3",
    "title": "Title bug in DeepOrangeTasksApi",
    "content": {
        "text": "There is bug with tasks, when you change title it returns 404 code in response",
        "photos": [
            "photo1.png", "photo2.png", "photo3.png"
        ],
        "videos": [
            "video1.mp4"
        ]
    },
    "createdBy": "c5286121-8614-42a1-b8bc-a9589730223e",
    "createdAt": "25.06.2023 11:14",
    "updateAt": "",
    "finishedAt": ""
}
```

### Get

```js
GET {{host}}/api/v1.0/tasks
```

### Get response

```js
200 OK
```

```json
{
    {
        "id": "d800dio3-spo3-b4893-jdsfk3",
        "title": "Title bug in DeepOrangeTasksApi",
        "content": {
            "text": "There is bug with tasks, when you change title it returns 404 code in response",
            "photos": [
                "photo1.png", "photo2.png", "photo3.png"
            ],
            "videos": [
                "video1.mp4"
            ]
        },
        "createdBy": "c5286121-8614-42a1-b8bc-a9589730223e",
        "createdAt": "25.06.2023 11:14",
        "updateAt": "",
        "finishedAt": ""
    },
    {
        "id": "a230lks4-fl1wt3-jf43wj23-jsf34dl2kf",
        "title": "Get bug in DeepOrangeProfileApi",
        "content": {
            "text": "Don't display profile id",
            "photos": [
                "photo5.png", "photo6.png", "photo7.png"
            ],
            "videos": [
                "video2.mp4"
            ]
        },
        "createdBy": "3giw90b5-d892-v89s-jk3l-g5089782639b",
        "createdAt": "26.06.2023 16:35",
        "updateAt": "29.06.2023 08:51",
        "finishedAt": "28.06.2023 10:23"
    }
}
```

### Get one

```js
GET {{host}}/api/v1.0/tasks/d800dio3-spo3-b4893-jdsfk3
```

### Get one Response

```js
200 OK
```

```json
{
    "id": "d800dio3-spo3-b4893-jdsfk3",
    "title": "Title bug in DeepOrangeTasksApi",
    "content": {
        "text": "There is bug with tasks, when you change title it returns 404 code in response",
        "photos": [
            "photo1.png", "photo2.png", "photo3.png"
        ],
        "videos": [
            "video1.mp4"
        ]
    },
    "createdBy": "c5286121-8614-42a1-b8bc-a9589730223e",
    "createdAt": "25.06.2023 11:14",
    "updateAt": "",
    "finishedAt": ""
}
```

### Update one

```js
UPDATE {{host}}/api/v1.0/tasks/d800dio3-spo3-b4893-jdsfk3
```

### Update one Request

```json
{
    "title": "Profiles bug in DeepOrangeProfileApi",
    "content": {
        "text": "Profiles return with 204 code(empty)",
        "photos": [],
        "videos": [
            "video3.mp4"
        ]
    }
}
```

### Update one Response

```js
200 OK
```

```json
{
    "id": "d800dio3-spo3-b4893-jdsfk3",
    "title": "Profiles bug in DeepOrangeProfileApi",
    "content": {
        "text": "Profiles return with 204 code(empty)",
        "photos": [],
        "videos": [
            "video3.mp4"
        ]
    },
    "createdBy": "c5286121-8614-42a1-b8bc-a9589730223e",
    "createdAt": "25.06.2023 11:14",
    "updateAt": "25.06.2023 13:25",
    "finishedAt": ""
}
```

### Patch one

```js
PATCH {{host}}/api/v1.0/tasks/d800dio3-spo3-b4893-jdsfk3
```

### Patch one Request

```json
{
    "title": "Header bug in DeepOrangeTasksApi",
    "content": {
        "text": "",
        "photos": [
            ""
        ],
        "videos": [
            "video4.mp4"
        ]
    }
}
```

### Patch one Response

```js
200 OK
```

```json
{
    "id": "d800dio3-spo3-b4893-jdsfk3",
    "title": "Header bug in DeepOrangeTasksApi",
    "content": {
        "text": "There is bug with tasks, when you change title it returns 404 code in response",
        "photos": [
            "photo1.png", "photo2.png", "photo3.png"
        ],
        "videos": [
            "video4.mp4"
        ]
    },
    "createdBy": "c5286121-8614-42a1-b8bc-a9589730223e",
    "createdAt": "25.06.2023 11:14",
    "updateAt": "25.06.2023 13:25",
    "finishedAt": ""
}
```

### Delete one

```js
DELETE {{host}}/api/v1.0/tasks/d800dio3-spo3-b4893-jdsfk3
```

### Delete one response

```js
200 OK
```