# CrazyMusiciansWebApi

CrazyMusiciansWebApi is a simple ASP.NET Core Web API that manages a collection of fictional musicians. It allows users to retrieve, create, update, and delete musicians, along with searching them by name.

## Features
- Retrieve all musicians
- Retrieve a musician by ID
- Add a new musician
- Update an existing musician
- Change a musician's name
- Delete a musician
- Search musicians by name

## Technologies Used
- ASP.NET Core Web API
- C#
- In-memory data storage

## Installation & Setup

### Prerequisites
- .NET 6.0 or later installed

### Steps
1. Clone the repository:
   ```sh
   git clone https://github.com/yourusername/CrazyMusiciansWebApi.git
   ```
2. Navigate to the project directory:
   ```sh
   cd CrazyMusiciansWebApi
   ```
3. Restore dependencies:
   ```sh
   dotnet restore
   ```
4. Build the project:
   ```sh
   dotnet build
   ```
5. Run the application:
   ```sh
   dotnet run
   ```
6. The API will be available at `http://localhost:5000` or `https://localhost:5001`.

## API Endpoints

### Get All Musicians
**Request:**
```http
GET /api/musicians
```
**Response:**
```json
[
  {
    "id": 1,
    "fullName": "Ahmet Çalgı",
    "job": "Ünlü Çalgı Çalar",
    "funFeature": "Her zaman yanlış nota çalar, ama çok eğlenceli"
  }
]
```

### Get Musician by ID
**Request:**
```http
GET /api/musicians/{id}
```
**Response:**
```json
{
  "id": 1,
  "fullName": "Ahmet Çalgı",
  "job": "Ünlü Çalgı Çalar",
  "funFeature": "Her zaman yanlış nota çalar, ama çok eğlenceli"
}
```

### Add a New Musician
**Request:**
```http
POST /api/musicians/create-artist
```
**Body:**
```json
{
  "fullName": "New Artist",
  "job": "New Job",
  "funFeature": "Interesting Fun Fact"
}
```
**Response:**
```json
{
  "id": 11,
  "fullName": "New Artist",
  "job": "New Job",
  "funFeature": "Interesting Fun Fact"
}
```

### Update a Musician
**Request:**
```http
PUT /api/musicians/update/{id}
```
**Body:**
```json
{
  "fullName": "Updated Artist",
  "job": "Updated Job",
  "funFeature": "Updated Fun Fact"
}
```

### Change Musician Name
**Request:**
```http
PATCH /api/musicians/change-name/{id}
```
**Body:**
```json
{
  "fullName": "New Name"
}
```

### Delete a Musician
**Request:**
```http
DELETE /api/musicians/cancel/{id}
```

### Search for a Musician
**Request:**
```http
POST /api/musicians/search?fullName=Ali Perde
```
**Response:**
```json
[]
```

## License
This project is licensed under the MIT License.

